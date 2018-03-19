function ClearErrors() {
    var errors = document.getElementsByClassName('error_message');

    while (errors[0]) {
        errors[0].parentNode.removeChild(errors[0]);
    }

    errors = document.getElementsByClassName('error');

    var errortest = $('.error');

    for (var i = 0; i < errors.length; i++) {
        errors[i].classList.remove("error");
    }
}

function GetBlog(id) {
        var errors = document.getElementsByClassName('error_message');

        while (errors[0]) {
            errors[0].parentNode.removeChild(errors[0]);
        }

        errors = document.getElementsByClassName('error');

        for (var i = 0; i < errors.length; i++) {
            errors[i].classList.remove("error");
        }
    $.ajax({
        url: "/home/GetBlogInfo",
        type: 'post',
        data: { id: id },
        success: function (data) {
            if (data.id > 0) {
                $('#title_input').val(data.title);
                $('#summary_input').val(data.summary);
                $('.fr-placeholder').text("");
                $('#datetime_input').val(data.publishedDateTime);
                $('div.fr-wrapper > div > p').text(data.content);
                $('#blogid').val(data.id);
                $('.editBlog').show();
            }
        }
    });
}

function CreateBlog() {
    $('#title_input').val("");
    $('#summary_input').val("");
    $('#datetime_input').val("");
    var test = $('.fr-element.fr-view');
    test[0].textContent = "";
    $('#blogid').val(0);

    ClearErrors();

    $('.editBlog').show();
}

function CancelBlog() {

    $('.editBlog').hide();
}



function SaveBlog() {
    var good = true;
    var titleinput = $('#title_input').val();
    var summaryinput = $('#summary_input').val();
    var test = $('#datetime_input');
    var datetimeinput = test[0].value;
    ClearErrors();
    if (titleinput == "") {
        $('#title_input').addClass("error");
        $('.blog_title_container').append("<div class='error_message'>Title cannot be empty!</div>");
        good = false;
    }
    if (summaryinput == "") {
        $('#summary_input').addClass("error");
        $('.blog_summary_container').append("<div class='error_message'>Summary cannot be empty!</div>");
        good = false;
    }
    if (datetimeinput == "") {
        $('#datetime_input').addClass("error");
        $('.blog_datetime_container').append("<div class='error_message'>Please enter full date and time!</div>");
        good = false;
    }

    if (Date.parse(datetimeinput) < Date.now()) {
        $('#datetime_input').addClass("error");
        $('.blog_datetime_container').append("<div class='error_message'>Datetime cannot be in the past!</div>");
        good = false;
    }

    test = $(".fr-element.fr-view");

    if (test[0].textContent == "") {
        $('#title_input').addClass("error");
        $('.blog_content_container').append("<div class='error_message'>Content cannot be empty!</div>");
        good = false;
    }


    if (good == true) {

        ClearErrors();

        var data = {};
        if ($('#blogid').val() == 0) {
            data["title"] = titleinput;
            data["summary"] = summaryinput;
            data["publishedDateTime"] = datetimeinput;
            data["content"] = test[0].textContent;
            data["userID"] = $('#userid').val();
            //data = json.stringify(data);
            $.ajax({
                url: "/home/CreateBlog",
                type: 'post',
                //contentType: 'application/json',
                //dataType: "json",
                data: { data: data },
                success: function (data) {
                    if (data > 0) {

                        var table = $('#blogtable');
                        table = table[0];
                        var rows = document.getElementsByClassName('tablerow').length;
                        var row = table.insertRow(rows);
                        $('.noblogs').remove();
                        row.setAttribute("data-id", data);
                        row.className = "tablerow";
                        row.onclick = function () {
                            GetBlog(data);
                        };
                        var titlecell = row.insertCell(0);
                        titlecell.innerHTML = titleinput;
                        titlecell.className = "tablecell";
                        var summarycell = row.insertCell(1);
                        summarycell.innerHTML = summaryinput;
                        summarycell.className = "tablecell";
                        var datetimecell = row.insertCell(2);
                        datetimeinput = moment(datetimeinput).format('hh:mm DD MMM YYYY');
                        datetimecell.innerHTML = datetimeinput;
                        datetimecell.className = "tablecell";

                    }
                    else {
                        alert("Failed to create blog, invalid values were sent");
                    }
                    $('.editBlog').hide();
                }
            });
        }
        else if ($('#blogid').val() > 0) {
            if (titleinput.length < 64 && titleinput != ""
                && summaryinput.length < 350 && summaryinput != ""
                && test[0].textContent.length < 350 && test[0].textContent != "") {
                data["title"] = titleinput;
                data["summary"] = summaryinput;
                data["publishedDateTime"] = datetimeinput;
                data["content"] = test[0].textContent;
                data["id"] = $('#blogid').val();
                data["userID"] = $('#userid').val();
                $.ajax({
                    url: "/home/UpdateBlog",
                    type: 'post',

                    data: { data: data },
                    success: function () {
                        var target = $('tr[data-id="' + $('#blogid').val() + '"]');
                        target = target[0];
                        target.innerHTML = "<tr data-id='" + $('#blogid').val() + "' class='tablerow' onclick='GetBlog(" + $('#blogid').val() + ")'>" +
                            '<td class="tablecell">' +
                            titleinput +
                            ' </td > ' +
                            '<td class="tablecell">' +
                            summaryinput +
                            '</td>' +
                            '<td class="tablecell">' +
                            moment(datetimeinput).format('hh:mm DD MMM YYYY');
                        '</td>';
                        $('.editBlog').hide();
                    }
                });
            }
            else {
                alert("Failed to update blog, invalid values were sent");
            }
        }
    }
}