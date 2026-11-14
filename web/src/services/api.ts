const baseUrl = import.meta.env.VITE_API_URL

export async function apiGet<T>(path: string): Promise<T> {
    const response = await fetch(`${baseUrl}${path}`)
    if (!response.ok) {
        throw new Error(`Error ${response.status} al llamar a ${path}`)
    }
    return response.json() as Promise<T>
}

console.log('API URL:', import.meta.env.VITE_API_URL)