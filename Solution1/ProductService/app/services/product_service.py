from app.models.product import Product

class ProductService:
    def __init__(self):
        self.products = [
            Product(1, "لپ‌تاپ", 25000000, 10),
            Product(2, "موبایل", 12000000, 25)
        ]
    
    def get_product_by_id(self, product_id: int):
        for product in self.products:
            if product.id == product_id:
                return product
        return None
    
    def search_products(self, query: str):
        return [p for p in self.products if query.lower() in p.name.lower()]