'use client'
import { useState } from 'react'

export default function ParentPage() {
  const [form, setForm] = useState({
    name: '',
    phone: '',
    telegram: '',
    district: '',
    childAge: '',
    schedule: '',
    liveIn: false,
    language: '',
    budget: 0,
    comment: ''
  })
  const [status, setStatus] = useState('')

  const submit = async (e: React.FormEvent) => {
    e.preventDefault()
    const res = await fetch('/api/request', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(form)
    })
    setStatus(res.ok ? 'Заявка сохранена' : 'Ошибка сохранения')
  }

  return (
    <main className="container">
      <h1>Заявка родителя</h1>
      <form className="form" onSubmit={submit}>
        <input required placeholder="Имя" value={form.name} onChange={e=>setForm({...form,name:e.target.value})}/>
        <input required placeholder="Телефон" value={form.phone} onChange={e=>setForm({...form,phone:e.target.value})}/>
        <input placeholder="Telegram username" value={form.telegram} onChange={e=>setForm({...form,telegram:e.target.value})}/>
        <input required placeholder="Район Тбилиси" value={form.district} onChange={e=>setForm({...form,district:e.target.value})}/>
        <input required placeholder="Возраст ребенка" value={form.childAge} onChange={e=>setForm({...form,childAge:e.target.value})}/>
        <input required placeholder="График: weekdays, evenings" value={form.schedule} onChange={e=>setForm({...form,schedule:e.target.value})}/>
        <label><input type="checkbox" checked={form.liveIn} onChange={e=>setForm({...form,liveIn:e.target.checked})}/> Нужна няня с проживанием</label>
        <input required placeholder="Язык: ru/en/ka" value={form.language} onChange={e=>setForm({...form,language:e.target.value})}/>
        <input required type="number" placeholder="Бюджет GEL/час" value={form.budget || ''} onChange={e=>setForm({...form,budget:Number(e.target.value)})}/>
        <textarea required placeholder="Комментарий" value={form.comment} onChange={e=>setForm({...form,comment:e.target.value})}/>
        <button type="submit">Отправить</button>
      </form>
      {status && <p className="notice">{status}</p>}
    </main>
  )
}
