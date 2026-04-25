import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

async function main() {
  await prisma.nanny.createMany({
    data: [
      { name: 'Anna', phone: '+995555000001', district: 'Vake', languages: 'ru,en', experience: '5 years', childAges: '0-5', availability: 'full-time', rate: 20, description: 'Experienced nanny', documentConsent: true },
      { name: 'Maya', phone: '+995555000002', district: 'Saburtalo', languages: 'ru', experience: '3 years', childAges: '3-10', availability: 'part-time', rate: 15, description: 'Calm and kind', documentConsent: true }
    ]
  })

  await prisma.parentRequest.createMany({
    data: [
      { name: 'Ivan', phone: '+995555111111', district: 'Vake', childAge: '3', schedule: 'day', language: 'ru', budget: 18, comment: 'Need nanny urgently' }
    ]
  })
}

main().finally(() => prisma.$disconnect())
