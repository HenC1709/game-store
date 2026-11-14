import type { Product } from '../types/product'
import './ProductCard.css'

export default function ProductCard({ product }: { product: Product }) {
    return (
        <article className="product-card">
            <img className="product-card__image" src={product.imageUrl} alt={product.name} />
            <div className="product-card__body">
                <h3 className="product-card__name">{product.name}</h3>
                <p className="product-card__platform">{product.platform}</p>
                <p className="product-card__price">${product.price.toFixed(2)}</p>
                <span className={product.inStock ? 'product-card__stock' : 'product-card__stock product-card__stock--out'}>
                    {product.inStock ? 'Disponible' : 'Agotado'}
                </span>
            </div>
        </article>
    )
}