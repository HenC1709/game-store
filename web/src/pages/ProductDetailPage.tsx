import { Link, useParams } from 'react-router'
import EmptyState from '../components/EmptyState'
import ErrorMessage from '../components/ErrorMessage'
import Spinner from '../components/Spinner'
import { useProduct } from '../hooks/useProduct'
import './ProductDetailPage.css'

export default function ProductDetailPage() {
    const { id } = useParams()
    const { product, loading, error } = useProduct(Number(id))

    if (loading) return <Spinner />
    if (error) return <ErrorMessage message={error} />
    if (!product) return <EmptyState text="Juego no encontrado." />

    return (
        <article className="product-detail">
            <Link className="product-detail__back" to="/">← Volver al catálogo</Link>
            <div className="product-detail__content">
                <img className="product-detail__image" src={product.imageUrl} alt={product.name} />
                <div className="product-detail__info">
                    <h1 className="product-detail__name">{product.name}</h1>
                    <p className="product-detail__meta">{product.platform} · {product.genre}</p>
                    <p className="product-detail__description">{product.description}</p>
                    <p className="product-detail__price">${product.price.toFixed(2)}</p>
                    <span className={product.inStock ? 'product-detail__stock' : 'product-detail__stock product-detail__stock--out'}>
                        {product.inStock ? 'Disponible' : 'Agotado'}
                    </span>
                </div>
            </div>
        </article>
    )
}