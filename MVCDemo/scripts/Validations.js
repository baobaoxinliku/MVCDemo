function IsValid() {
    var pwd1 = $("UserPwd").val();
    var pwd2 = $("UserPwd2").val();
    if (pwd1 == pwd2) {
        return true;
    }
    else{
        alert("两次密码不一致");
        return false;
    }
}