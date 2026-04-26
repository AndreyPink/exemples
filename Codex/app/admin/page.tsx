import { getStore } from '@/lib/store'

export default async function AdminPage() {
  const { nannies, requests } = getStore()

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
