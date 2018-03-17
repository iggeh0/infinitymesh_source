function Validate() {
    var username = document.getElementById('inputUsername');
    var password = document.getElementById('inputPassword');
    if (username.value.length > 3 && password.value.length > 3) {
        //$.ajax({
        //    url: "home/LoginCheck",
        //    type: 'post',
        //    data: { username : username.value, password : password.value },
        //    success: function (data) {
        //        if (data > 0)
        //        {
        //            var target = data;
        //            $.ajax({
        //                url: "home/LoginConfirmed",
        //                type: 'post',
        //                data: { id: target },
        //                success: function () {
        //                    window.location = "/home/LoginConfirmed/" + target;
        //                }
        //            });
        //        }
        //    }
        //});
        document.getElementById('loginform').submit();
    }
}



//function Login(username, password)
//{
//    $.ajax({
//        type: "POST",
//        url: "home/LoginCheck",
//        data: { username: username, password: password },
//        success: function (data) {
//            alert(data);
//        }

//    });

//}