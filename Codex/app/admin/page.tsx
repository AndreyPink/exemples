import { prisma } from '@/lib/prisma'

export default async function AdminPage() {
  const nannies = await prisma.nanny.findMany()
  const requests = await prisma.parentRequest.findMany()

  return (
    <div style={{padding:20}}>
      <h1>Админка</h1>

      <h2>Няни</h2>
      {nannies.map(n => (
        <div key={n.id}>
          {n.name} ({n.district}) - {n.rate}
        </div>
      ))}

      <h2>Заявки</h2>
      {requests.map(r => (
        <div key={r.id}>
          {r.name} ({r.district}) - {r.budget}
        </div>
      ))}
    </div>
  )
}
