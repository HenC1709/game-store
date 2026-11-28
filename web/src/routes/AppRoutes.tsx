import { Route, Routes } from 'react-router'
import CatalogPage from '../pages/CatalogPage'
import ProductDetailPage from '../pages/ProductDetailPage'

export default function AppRoutes() { 
    return (
        <Routes>
            <Route path="/" element={<CatalogPage />} />
            <Route path="/products/:id" element={<ProductDetailPage />} />
        </Routes>
    )
}