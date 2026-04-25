'use client'
import { useState } from 'react'

const initialForm = {
  name:'', phone:'', telegram:'', district:'', childAge:'', schedule:'', liveIn:false,
  language:'', budget:0, comment:''
}

export default function ParentPage(){
  const [form,setForm]=useState(initialForm)
  const [status,setStatus]=useState('')

  const set=(k:string,v:any)=>setForm(p=>({...p,[k]:v}))

  const submit=async(e:any)=>{
    e.preventDefault()
    const res=await fetch('/api/request',{method:'POST',headers:{'Content-Type':'application/json'},body:JSON.stringify(form)})
    setStatus(res.ok?'Заявка отправлена':'Ошибка')
    if(res.ok)setForm(initialForm)
  }

  return (
    <main className="container">
      <h1>Заявка родителя</h1>
      <form className="form" onSubmit={submit}>
        <input required placeholder="Имя" value={form.name} onChange={e=>set('name',e.target.value)}/>
        <input required placeholder="Телефон" value={form.phone} onChange={e=>set('phone',e.target.value)}/>
        <input placeholder="Telegram" value={form.telegram} onChange={e=>set('telegram',e.target.value)}/>
        <input required placeholder="Район" value={form.district} onChange={e=>set('district',e.target.value)}/>
        <input required placeholder="Возраст ребенка" value={form.childAge} onChange={e=>set('childAge',e.target.value)}/>
        <input required placeholder="График" value={form.schedule} onChange={e=>set('schedule',e.target.value)}/>
        <label><input type="checkbox" checked={form.liveIn} onChange={e=>set('liveIn',e.target.checked)}/> С проживанием</label>
        <input required placeholder="Язык" value={form.language} onChange={e=>set('language',e.target.value)}/>
        <input required type="number" placeholder="Бюджет" value={form.budget||''} onChange={e=>set('budget',Number(e.target.value))}/>
        <textarea placeholder="Комментарий" value={form.comment} onChange={e=>set('comment',e.target.value)}/>
        <button>Отправить</button>
      </form>
      {status && <p>{status}</p>}
    </main>
  )
}
