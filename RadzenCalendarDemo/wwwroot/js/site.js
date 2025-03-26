    window.initDateTimePicker = (elementId, dotNetHelper) => {
        flatpickr(`#${elementId}`, {
            enableTime: true,
            dateFormat: "Y-m-d H:i",
            onChange: function (selectedDates, dateStr, instance) {
                dotNetHelper.invokeMethodAsync('OnDateSelected', dateStr);
            }
        });
};
