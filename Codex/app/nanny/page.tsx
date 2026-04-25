'use client'
import { useState } from 'react'

export default function NannyPage() {
  const [form, setForm] = useState<any>({})

  const submit = async () => {
    await fetch('/api/nanny', {
      method: 'POST',
      body: JSON.stringify(form)
    })
    alert('Saved')
  }

  return (
    <div style={{padding:20}}>
      <h2>Регистрация няни</h2>
      <input placeholder="Имя" onChange={e=>setForm({...form,name:e.target.value})}/>
      <input placeholder="Телефон" onChange={e=>setForm({...form,phone:e.target.value})}/>
      <input placeholder="Район" onChange={e=>setForm({...form,district:e.target.value})}/>
      <input placeholder="Языки" onChange={e=>setForm({...form,languages:e.target.value})}/>
      <button onClick={submit}>Отправить</button>
    </div>
  )
}
