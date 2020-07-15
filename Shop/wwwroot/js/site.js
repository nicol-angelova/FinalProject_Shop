function getItemToDelete(id, item) {
    var $item = $("#orderToDeleteName");
    var $id = $("#orderToDeleteId");

    $item.html(item);
    $id.html(id);
}

function deleteItem() {
    var $id = $('#orderToDeleteId').html();

    window.location = "DeleteItem/" + $id;
}

function cancelAdd() {
    var $button = $(".add-button-wrapper");
    var $form = $(".add-form-wrapper");

    $form.addClass("invisible");
    $button.removeClass("invisible");
}

function addEvent() {
    var $button = $(".add-button-wrapper");
    var $form = $(".add-form-wrapper");

    $button.addClass("invisible");
    $form.removeClass("invisible");
}

function edit(id) {
    window.location = "Orders/Edit/" + id
}