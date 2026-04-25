export default function Home() {
  return (
    <main style={{padding:20}}>
      <h1>Nanny Service Tbilisi</h1>
      <p>Подбор проверенных нянь в Тбилиси</p>
      <div style={{display:'flex',gap:10}}>
        <a href="/nanny">Я няня</a>
        <a href="/parent">Я родитель</a>
        <a href="/admin">Админка</a>
      </div>
    </main>
  )
}
