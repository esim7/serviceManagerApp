# ServiceRequestApplication

Простое веб-приложение которое должно контролировать обработку заявок от клиентов в небольшой организации. Поступающая заявка на обслуживание принимается сотрудником организации посредством телефонной связи, далее уполномоченный сотрудник оформляет заявку в данном приложении с выбором ответственного лица(работник). Работник берет заявку на исполнение, фиксируется дата принятия в работу заявки и дата исполнения заявки.  


## Цель приложения

Основной целью данного приложения является минимизировать время простоя, сделать деятельность подразделения которое исполняют заказы более прозрачной а его сотрудников контролируемой.  

```bash
Хорош отдых, когда работа сделана.
```

## FAQ по проектам
Название  | Описание
----------------|----------------------
ServiceReqApp.DataAccess       | Проект с EF core
ServiceReqApp.Domain       | Проект содержащий все сущности приложения
ServiceReqApp.Infrastructure   | Слой некой абстракции, содержит папки с интерфейсами, их реализацией, классы DTO и extension методы регистрации сервисов(репозитории и UOW)
ServiceReqApp       | Основной запускаемый проект

## PS
*Реализация данного проекта была выбрана в первую очередь в практических целях, помимо дефолтных операций с заявками в планах добавить функционал для общения между сотрудниками, новостную ленту, сводку по важным мероприятиям для компании и т.д*

Учитывая планы по расширению функционала приложения(не из списка выше) стараюсь писать так чтобы в потом можно было безболезненно добавить что то новое.



##  
***esim7 2020***