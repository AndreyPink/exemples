import { addRequest } from '@/lib/store'

export async function POST(req: Request) {
  const data = await req.json()
  addRequest(data)
  return new Response(JSON.stringify({ ok: true }))
}
