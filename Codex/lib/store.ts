import fs from 'node:fs'
import path from 'node:path'

type Nanny = {
  id: number
  name: string
  phone: string
  telegram?: string
  district: string
  languages: string
  experience: string
  childAges: string
  availability: string
  rate: number
  photoUrl?: string
  description: string
  documentConsent: boolean
  status: string
  createdAt: string
  updatedAt: string
}

type ParentRequest = {
  id: number
  name: string
  phone: string
  telegram?: string
  district: string
  childAge: string
  schedule: string
  liveIn: boolean
  language: string
  budget: number
  comment: string
  status: string
  createdAt: string
  updatedAt: string
}

type StoreData = {
  nannies: Nanny[]
  requests: ParentRequest[]
}

const dataDir = path.join(process.cwd(), 'data')
const dataFile = path.join(dataDir, 'store.json')

function ensureStore() {
  if (!fs.existsSync(dataDir)) fs.mkdirSync(dataDir, { recursive: true })
  if (!fs.existsSync(dataFile)) {
    fs.writeFileSync(dataFile, JSON.stringify({ nannies: [], requests: [] }, null, 2), 'utf-8')
  }
}

function readStore(): StoreData {
  ensureStore()
  return JSON.parse(fs.readFileSync(dataFile, 'utf-8')) as StoreData
}

function writeStore(data: StoreData) {
  fs.writeFileSync(dataFile, JSON.stringify(data, null, 2), 'utf-8')
}

export function getStore() {
  return readStore()
}

export function addNanny(payload: Omit<Nanny, 'id' | 'status' | 'createdAt' | 'updatedAt'>) {
  const store = readStore()
  const now = new Date().toISOString()
  const nanny: Nanny = {
    id: store.nannies.length ? store.nannies[store.nannies.length - 1].id + 1 : 1,
    status: 'new',
    createdAt: now,
    updatedAt: now,
    ...payload
  }
  store.nannies.push(nanny)
  writeStore(store)
  return nanny
}

export function addRequest(payload: Omit<ParentRequest, 'id' | 'status' | 'createdAt' | 'updatedAt'>) {
  const store = readStore()
  const now = new Date().toISOString()
  const request: ParentRequest = {
    id: store.requests.length ? store.requests[store.requests.length - 1].id + 1 : 1,
    status: 'new',
    createdAt: now,
    updatedAt: now,
    ...payload
  }
  store.requests.push(request)
  writeStore(store)
  return request
}
