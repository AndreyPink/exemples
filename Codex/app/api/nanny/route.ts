import { addNanny } from '@/lib/store'

export async function POST(req: Request) {
  const data = await req.json()
  addNanny(data)
  return new Response(JSON.stringify({ ok: true }))
}
