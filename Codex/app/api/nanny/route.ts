import { prisma } from '@/lib/prisma'

export async function POST(req: Request) {
  const data = await req.json()
  await prisma.nanny.create({ data })
  return new Response(JSON.stringify({ ok: true }))
}
