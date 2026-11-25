import { useEffect, useState } from 'react'
import type { ProductDetail } from '../types/product'
import { getProductById } from '../services/productService'

type State = { id: number; product: ProductDetail | null; error: string | null }

export function useProduct(id: number) {
    const [state, setState] = useState<State | null>(null)

    useEffect(() => {
        let cancelled = false

        getProductById(id)
            .then(product => { if (!cancelled) setState({ id, product, error: null }) })
            .catch(err => { if (!cancelled) setState({ id, product: null, error: err.message }) })

        return () => { cancelled = true }
    }, [id])

    const ready = state !== null && state.id === id

    return {
        product: ready ? state.product : null,
        loading: !ready,
        error: ready ? state.error : null,
    }
}