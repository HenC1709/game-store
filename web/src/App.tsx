import CatalogPage from './pages/CatalogPage'
import Navbar from './components/Navbar'
import Footer from'./components/Footer'

export default function App() {
  return(
    <>
      <Navbar />
      <main>
         <CatalogPage />
      </main>
      <Footer />
    </>
  )
}
