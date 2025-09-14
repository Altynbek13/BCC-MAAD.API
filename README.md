Вот красиво оформленный `README.md` для GitHub с акцентом на удобство чтения и структуру:

````markdown
# BCC-MAAD.API

**BCC-MAAD.API** — это RESTful API на **.NET 8**, предназначенный для управления клиентами, транзакциями и переводами.  
Проект реализует аутентификацию через JWT, работу с профилями клиентов, обработку финансовых операций и интеграцию с Docker.

---

## 🚀 Возможности

- 🔑 Регистрация и аутентификация пользователей (**JWT**)
- 👤 Получение информации о текущем пользователе
- 📝 Управление профилями клиентов
- 💸 Создание и просмотр транзакций
- 🔄 Переводы между клиентами
- 📊 Получение баланса и истории операций

---

## 🛠 Стек технологий

- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- ASP.NET Core Web API
- Entity Framework Core
- JWT (JSON Web Token)
- Docker

---

## ⚡ Быстрый старт

### 🔹 Локальный запуск

1. Установите [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)  
2. В корне проекта выполните команды:

   ```bash
   dotnet restore
   dotnet build
   dotnet run --project BCC-MAAD.API/BCC-MAAD.API.csproj
````

3. API будет доступен по адресу:
   👉 [http://localhost:6666](http://localhost:6666)

---

### 🔹 Запуск в Docker

1. Установите [Docker](https://www.docker.com/)
2. Соберите и запустите контейнер:

   ```bash
   docker build -t bcc-maad-api -f BCC-MAAD.API/Dockerfile .
   docker run -p 6666:6666 bcc-maad-api
   ```

---

## ⚙️ Конфигурация

Все основные настройки находятся в файлах:

* `appsettings.json`
* `appsettings.Development.json`

---

## 📌 Примеры запросов

* `POST /api/auth/register` — регистрация пользователя
* `POST /api/auth/login` — вход пользователя
* `GET /api/clients/{id}` — получение профиля клиента
* `POST /api/transfers` — перевод средств

---

## 📂 Структура проекта

```
BCC-MAAD.API/
├── Controllers/      # Обработчики HTTP-запросов
├── Services/         # Бизнес-логика
├── Entities/         # Модели данных
├── DTOs/             # Объекты передачи данных
└── AppDbContext.cs   # Контекст базы данных
```

