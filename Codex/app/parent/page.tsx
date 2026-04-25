'use client'
import { useState } from 'react'

export default function ParentPage() {
  const [form, setForm] = useState<any>({})

  const submit = async () => {
    await fetch('/api/request', {
      method: 'POST',
      body: JSON.stringify(form)
    })
    alert('Saved')
  }

  return (
    <div style={{padding:20}}>
      <h2>Заявка родителя</h2>
      <input placeholder="Имя" onChange={e=>setForm({...form,name:e.target.value})}/>
      <input placeholder="Телефон" onChange={e=>setForm({...form,phone:e.target.value})}/>
      <input placeholder="Район" onChange={e=>setForm({...form,district:e.target.value})}/>
      <button onClick={submit}>Отправить</button>
    </div>
  )
}
