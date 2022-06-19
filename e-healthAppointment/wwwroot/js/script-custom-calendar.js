$(Document).ready(function () {
    InitializeCalendar();
});

function InitializeCalendar() {
    try {

        $('Calendar').fullCalendar(
            {
                timezone: false,
                header: {
                    left: 'prev,nex,today',
                    center: 'title',
                    right: 'month,AgendWeek, AgendDay'
                },
                selectable: true,
                editable: false
            });
    }
    catch (e) {
        alert(e);
    }
}