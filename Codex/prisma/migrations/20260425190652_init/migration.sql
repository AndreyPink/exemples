-- CreateTable
CREATE TABLE "Nanny" (
    "id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    "name" TEXT NOT NULL,
    "phone" TEXT NOT NULL,
    "telegram" TEXT,
    "district" TEXT NOT NULL,
    "languages" TEXT NOT NULL,
    "experience" TEXT NOT NULL,
    "childAges" TEXT NOT NULL,
    "availability" TEXT NOT NULL,
    "rate" INTEGER NOT NULL,
    "photoUrl" TEXT,
    "description" TEXT NOT NULL,
    "documentConsent" BOOLEAN NOT NULL DEFAULT false,
    "status" TEXT NOT NULL DEFAULT 'new',
    "createdAt" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "updatedAt" DATETIME NOT NULL
);

-- CreateTable
CREATE TABLE "ParentRequest" (
    "id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    "name" TEXT NOT NULL,
    "phone" TEXT NOT NULL,
    "telegram" TEXT,
    "district" TEXT NOT NULL,
    "childAge" TEXT NOT NULL,
    "schedule" TEXT NOT NULL,
    "liveIn" BOOLEAN NOT NULL DEFAULT false,
    "language" TEXT NOT NULL,
    "budget" INTEGER NOT NULL,
    "comment" TEXT NOT NULL,
    "status" TEXT NOT NULL DEFAULT 'new',
    "createdAt" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "updatedAt" DATETIME NOT NULL
);
