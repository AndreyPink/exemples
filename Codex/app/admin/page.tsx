import { prisma } from '@/lib/prisma'
import { matchNannies } from '@/lib/match'

function cleanPhone(phone:string){return phone.replace(/[^0-9]/g,'')}
function whatsapp(phone:string){return `https://wa.me/${cleanPhone(phone)}`}
function telegram(username?:string|null){if(!username)return null;return `https://t.me/${username.replace('@','')}`}

export default async function AdminPage(){
  const nannies=await prisma.nanny.findMany({orderBy:{createdAt:'desc'}})
  const requests=await prisma.parentRequest.findMany({orderBy:{createdAt:'desc'}})

  return (
    <main className="container">
      <h1>Админка</h1>

      <section className="card">
        <h2>Няни</h2>
        <table>
          <thead><tr><th>Имя</th><th>Район</th><th>Языки</th><th>Ставка</th><th>Статус</th><th>Связь</th></tr></thead>
          <tbody>{nannies.map(n=>(
            <tr key={n.id}>
              <td>{n.name}</td><td>{n.district}</td><td>{n.languages}</td><td>{n.rate} GEL</td><td>{n.status}</td>
              <td><a href={whatsapp(n.phone)} target="_blank">WhatsApp</a>{telegram(n.telegram)&&<> · <a href={telegram(n.telegram)!} target="_blank">Telegram</a></>}</td>
            </tr>
          ))}</tbody>
        </table>
      </section>

      <section className="card">
        <h2>Заявки родителей</h2>
        {requests.map(r=>{
          const matches=matchNannies(nannies,r)
          return (
            <div className="request" key={r.id}>
              <h3>{r.name} — {r.district}, бюджет {r.budget} GEL</h3>
              <p>Ребенок: {r.childAge}. График: {r.schedule}. Язык: {r.language}. Статус: {r.status}</p>
              <p><a href={whatsapp(r.phone)} target="_blank">WhatsApp родителю</a>{telegram(r.telegram)&&<> · <a href={telegram(r.telegram)!} target="_blank">Telegram</a></>}</p>
              <h4>Топ подходящих нянь</h4>
              <ol>{matches.map(m=>(
                <li key={m.nanny.id}>
                  <b>{m.nanny.name}</b> — score {m.score}; {m.nanny.district}, {m.nanny.languages}, {m.nanny.rate} GEL/час. <a href={whatsapp(m.nanny.phone)} target="_blank">WhatsApp</a>
                </li>
              ))}</ol>
            </div>
          )
        })}
      </section>
    </main>
  )
}
