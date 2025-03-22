// wwwroot/js/calendar.js
import { Calendar } from '@fullcalendar/core';
import dayGridPlugin from '@fullcalendar/daygrid';

window.initCalendar = (dotNetRef) => {
    var calendarEl = document.getElementById('calendar');
    var calendar = new Calendar(calendarEl, {
        plugins: [dayGridPlugin],
        initialView: 'dayGridMonth',
        dateClick: function (info) {
            dotNetRef.invokeMethodAsync('OnDateClicked', info.dateStr);
        }
    });
    calendar.render();
};