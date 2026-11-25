export type Product = {
    id: number
    name: string
    platform: string
    price: number
    imageUrl: string
    inStock: boolean
}

export type ProductDetail = {
    id: number
    name: string
    description: string
    platform: string
    genre: string
    price: number
    imageUrl: string
    inStock: boolean
}

export type ProductFilters = {
    search?: string
    platform?: string
    genre?: string
    maxPrice?: number
}