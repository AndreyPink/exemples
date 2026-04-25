import type { Metadata } from 'next'
import './styles.css'

export const metadata: Metadata = {
  title: 'Tbilisi Nanny MVP',
  description: 'MVP агрегатора нянь в Тбилиси'
}

export default function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="ru">
      <body>
        <nav className="nav">
          <a href="/">Главная</a>
          <a href="/parent">Я родитель</a>
          <a href="/nanny">Я няня</a>
          <a href="/admin">Админка</a>
        </nav>
        {children}
      </body>
    </html>
  )
}
