import { useEffect, useState } from 'react'
import type { Product, ProductFilters } from '../types/product'
import { getProducts } from '../services/productService'

type State = { key: string; products: Product[]; error: string | null }

export function useProducts(filters: ProductFilters = {}) {
    const [state, setState] = useState<State | null>(null)

    const { search, platform, genre, maxPrice } = filters
    // Identifica "qué filtros pedimos" con un texto, para saber si lo guardado sigue vigente.
    const key = JSON.stringify({ search, platform, genre, maxPrice })

    useEffect(() => {
        let cancelled = false

        getProducts({ search, platform, genre, maxPrice })
            .then(products => { if (!cancelled) setState({ key, products, error: null }) })
            .catch(err => { if (!cancelled) setState({ key, products: [], error: err.message }) })

        return () => { cancelled = true }
    }, [key, search, platform, genre, maxPrice])

    const ready = state !== null && state.key === key

    return {
        products: ready ? state.products : [],
        loading: !ready,
        error: ready ? state.error : null,
    }
}