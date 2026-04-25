'use client'
import { useState } from 'react'

const initialForm = {
  name: '', phone: '', telegram: '', district: '', languages: '', experience: '',
  childAges: '', availability: '', rate: 0, photoUrl: '', description: '', documentConsent: false
}

export default function NannyPage() {
  const [form, setForm] = useState(initialForm)
  const [status, setStatus] = useState('')

  const set = (key: string, value: string | boolean | number) => setForm(prev => ({ ...prev, [key]: value }))

  const submit = async (e: React.FormEvent) => {
    e.preventDefault()
    const res = await fetch('/api/nanny', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ ...form, rate: Number(form.rate) })
    })
    setStatus(res.ok ? 'Анкета сохранена' : 'Ошибка сохранения')
    if (res.ok) setForm(initialForm)
  }

  return (
    <main className="container">
      <h1>Анкета няни</h1>
      <p>Заполните данные — администратор проверит анкету и свяжется с вами.</p>
      <form className="form" onSubmit={submit}>
        <input required placeholder="Имя" value={form.name} onChange={e=>set('name',e.target.value)} />
        <input required placeholder="Телефон, например +995555000001" value={form.phone} onChange={e=>set('phone',e.target.value)} />
        <input placeholder="Telegram username" value={form.telegram} onChange={e=>set('telegram',e.target.value)} />
        <input required placeholder="Район Тбилиси" value={form.district} onChange={e=>set('district',e.target.value)} />
        <input required placeholder="Языки: ru,en,ka" value={form.languages} onChange={e=>set('languages',e.target.value)} />
        <input required placeholder="Опыт: 3 years" value={form.experience} onChange={e=>set('experience',e.target.value)} />
        <input required placeholder="Возраст детей: 0-5, 3-10" value={form.childAges} onChange={e=>set('childAges',e.target.value)} />
        <input required placeholder="Доступность: weekdays, evenings, full-time" value={form.availability} onChange={e=>set('availability',e.target.value)} />
        <input required type="number" placeholder="Ставка GEL/час" value={form.rate || ''} onChange={e=>set('rate',Number(e.target.value))} />
        <input placeholder="URL фото" value={form.photoUrl} onChange={e=>set('photoUrl',e.target.value)} />
        <textarea required placeholder="Описание" value={form.description} onChange={e=>set('description',e.target.value)} />
        <label><input type="checkbox" checked={form.documentConsent} onChange={e=>set('documentConsent',e.target.checked)} /> Согласна на проверку документов</label>
        <button>Отправить анкету</button>
      </form>
      {status && <p className="notice">{status}</p>}
    </main>
  )
}
