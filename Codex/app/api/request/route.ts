import { prisma } from '@/lib/prisma'

export async function POST(req: Request) {
  const data = await req.json()
  await prisma.parentRequest.create({ data })
  return new Response(JSON.stringify({ ok: true }))
}
