import EmptyState from '../components/EmptyState'
import ErrorMessage from '../components/ErrorMessage'
import ProductGrid from '../components/ProductGrid'
import Spinner from '../components/Spinner'
import { useProducts } from '../hooks/useProducts'

export default function CatalogPage() {
    const { products, loading, error } = useProducts({ platform: 'PC' })

    if (loading) return <Spinner />
    if (error) return <ErrorMessage message={error} />
    if (products.length === 0) return <EmptyState text="No hay juegos disponibles." />

    return <ProductGrid products={products} />
}