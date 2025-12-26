🚀 BTC Salman Project
📌 English Version
Overview

BTC Salman is a modular backend solution built with ASP.NET Core and designed based on Clean Architecture, CQRS, and Domain-Driven Design (DDD) principles.

The project is structured to be scalable, maintainable, and event-driven, leveraging MongoDB for persistence and RabbitMQ for asynchronous messaging and inter-service communication.

🏗 Project Structure
src/
 ├── Common/
 │   ├── Common.Application
 │   ├── Common.Domain
 │   ├── Common.EventBus
 │   ├── Common.Infrastructure
 │   └── Common.Query
 │       ├── MongoDb
 │       ├── Filters
 │       ├── BaseDto
 │       ├── IQuery / IQueryHandler
 │
 ├── EndPoints/
 │   └── BTCSalman.Web

📦 Core Modules
🔹 Common.Domain

Domain entities, value objects, and business rules

No dependency on infrastructure or frameworks

🔹 Common.Application

Application services and use cases

Coordinates domain logic and workflows

🔹 Common.Infrastructure

Database and external service implementations

MongoDB context and repositories

RabbitMQ connection and configuration

🔹 Common.Query

Query side implementation of CQRS

Generic query handlers

MongoDB paging, filtering, and query extensions

🔹 Common.EventBus

Event-driven architecture layer

Integration with RabbitMQ

Publishes and consumes domain and integration events

Enables loose coupling between modules

🔹 BTCSalman.Web

ASP.NET Core Web API

Exposes HTTP endpoints

Authentication via Microsoft Identity Platform

Frontend dependencies managed via npm

🛠 Technologies & Tools

ASP.NET Core

.NET

MongoDB

RabbitMQ

CQRS Pattern

Domain-Driven Design (DDD)

Microsoft Identity Platform

npm

▶️ How to Run

Clone the repository:

git clone https://github.com/your-username/BtcSalman.git


Open the solution in Visual Studio

Configure services in appsettings.json:

MongoDB connection string

RabbitMQ host, username, and password

Microsoft Identity settings

Ensure MongoDB and RabbitMQ are running

Run the BTCSalman.Web project

📄 License

This project is licensed under the MIT License, allowing free use, modification, and distribution.

🇮🇷 نسخه فارسی
معرفی پروژه

BTC Salman یک پروژه بک‌اند ماژولار مبتنی بر ASP.NET Core است که با استفاده از اصول
Clean Architecture، CQRS و Domain-Driven Design (DDD) طراحی شده است.

این پروژه از MongoDB برای ذخیره‌سازی داده‌ها و از RabbitMQ برای ارتباطات غیرهمزمان و مبتنی بر رویداد استفاده می‌کند و ساختاری مقیاس‌پذیر و قابل توسعه دارد.

🏗 ساختار پروژه
src/
 ├── Common/
 │   ├── Application
 │   ├── Domain
 │   ├── EventBus
 │   ├── Infrastructure
 │   └── Query
 │
 ├── EndPoints/
 │   └── BTCSalman.Web

📦 ماژول‌های اصلی
🔹 Domain

شامل موجودیت‌ها، Value Objectها و قوانین اصلی کسب‌وکار

مستقل از دیتابیس و فریم‌ورک‌ها

🔹 Application

پیاده‌سازی یوزکیس‌ها و منطق کاربردی

هماهنگی بین Domain و Infrastructure

🔹 Infrastructure

پیاده‌سازی ارتباط با دیتابیس و سرویس‌های خارجی

تنظیمات و اتصال MongoDB

پیکربندی و اتصال RabbitMQ

🔹 Query

بخش Query در معماری CQRS

QueryHandlerهای جنریک

فیلتر و صفحه‌بندی داده‌ها در MongoDB

🔹 EventBus

پیاده‌سازی معماری Event-Driven

ارتباط ماژول‌ها از طریق RabbitMQ

ارسال و دریافت رویدادها بدون وابستگی مستقیم

🔹 BTCSalman.Web

Web API مبتنی بر ASP.NET Core

ارائه Endpointها

احراز هویت با Microsoft Identity Platform

مدیریت وابستگی‌های فرانت‌اند با npm

🛠 تکنولوژی‌ها

ASP.NET Core / .NET

MongoDB

RabbitMQ

CQRS

Domain-Driven Design

Microsoft Identity Platform

npm

▶️ نحوه اجرا

کلون کردن پروژه:

git clone https://github.com/your-username/BtcSalman.git


باز کردن Solution در Visual Studio

تنظیم فایل appsettings.json:

Connection String مربوط به MongoDB

اطلاعات RabbitMQ (Host, User, Password)

تنظیمات Identity

اجرای MongoDB و RabbitMQ

اجرای پروژه BTCSalman.Web

📄 لایسنس

این پروژه تحت لایسنس MIT منتشر شده و استفاده، تغییر و انتشار آن آزاد است.
