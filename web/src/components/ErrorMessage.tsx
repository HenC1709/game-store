// ErrorMessage.tsx
export default function ErrorMessage({ message }: { message: string }) {
    return <p role="alert">No se pudo cargar: {message}</p>
}