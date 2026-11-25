import type { Product, ProductDetail, ProductFilters } from '../types/product'
import { apiGet } from './api'

export const getProducts = (filters: ProductFilters = {}) => {
    const params = new URLSearchParams()
    if (filters.search) params.set('search', filters.search)
    if (filters.platform) params.set('platform', filters.platform)
    if (filters.genre) params.set('genre', filters.genre)
    if (filters.maxPrice !== undefined) params.set('maxPrice', String(filters.maxPrice))

    const query = params.toString()
    return apiGet<Product[]>(`/api/products${query ? `?${query}` : ''}`)
}

export const getProductById = (id: number) =>
    apiGet<ProductDetail>(`/api/products/${id}`)