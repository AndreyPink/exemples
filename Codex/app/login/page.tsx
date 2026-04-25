'use client'
import { useState } from 'react'

export default function Login(){
  const [pass,setPass]=useState('')

  const login=()=>{
    document.cookie=`admin=${pass}`
    location.href='/admin'
  }

  return (
    <div style={{padding:20}}>
      <h1>Admin Login</h1>
      <input type="password" onChange={e=>setPass(e.target.value)} />
      <button onClick={login}>Войти</button>
    </div>
  )
}
