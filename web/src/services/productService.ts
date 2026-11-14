import type { Product } from '../types/product'
import { apiGet } from './api'

export const getProducts = () => apiGet<Product[]>('/api/products')