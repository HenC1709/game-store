import './Navbar.css'
export default function Navbar() {
return(
   <nav className="navbar">
        <a className="navbar__logo" href="/">GameStore</a>
        <ul className="navbar__links">
            <li><a className="navbar__link navbar__link--active" href="/">Inicio</a></li>
            <li><a className="navbar__link" href="/catalogo">Catálogo</a></li>
            <li><a className="navbar__link" href="/favoritos">Favoritos</a></li>
            <li><a className="navbar__link" href="/login">Iniciar sesión</a></li>
       </ul>
   </nav>
   )
}
