from fastapi import FastAPI, HTTPException
from app.services.product_service import ProductService
from app.models.product import Product

app = FastAPI()
product_service = ProductService()

@app.get("/products/{product_id}")
def get_product(product_id: int):
    product = product_service.get_product_by_id(product_id)
    if not product:
        raise HTTPException(status_code=404, detail="محصول یافت نشد")
    return product.to_dict()

@app.get("/search")
def search_products(q: str):
    results = product_service.search_products(q)
    return {"results": [p.to_dict() for p in results]}

if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="0.0.0.0", port=8000)
