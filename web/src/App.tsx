import AppRoutes from './routes/AppRoutes'
import Navbar from './components/Navbar'
import Footer from'./components/Footer'

export default function App() {
  return(
    <>
      <Navbar />
      <main>
         <AppRoutes />
      </main>
      <Footer />
    </>
  )
}
