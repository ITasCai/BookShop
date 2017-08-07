function getFocus()  //设置用户名文本框获取焦点
{
    document.getElementById("txtLoginId").focus();
}

//验证通过执行的方法
function Success(controlId) {
    controlId.innerHTML = "<img style='height:20px;width:30px' src='../images/duihao.png'/>";
}
//去掉字符串前后左右的空格
function Trim(str) {
    return str.replace(/(^\s*)|(\s*$)/g, "");
}

//验证用户名
function CheckUserName() {
    var loginID = document.getElementById("txtLoginId");
    var myDivId = document.getElementById("ErrorId");
    if (Trim(loginID.value) == "") {
        myDivId.innerHTML = "<font color='red'>请输入用户名!</font>";
        return false;
    }
    var re = new RegExp("^[a-zA-z][a-zA-Z0-9_]{5,15}$");
    var result = re.test(loginID.value);
    if (!result) {
        myDivId.innerHTML = "<font color='red'>用户名不符合规范</font>";
        return false;
    } else {
        Success(myDivId);
        return true;
    }
}

//验证姓名
function CheckName() {
    var name = document.getElementById("txtName");
    var myDivName = document.getElementById("ErrorName");
    var re = new RegExp("^([\u4e00-\u9fa5]){2,7}$");
    var result = re.test(name.value);
    if (Trim(name.value) == "") {
        myDivName.innerHTML = "<font color='red'>请输入真实姓名!</font>";
        return false;
    }
    if (!result) {
        myDivName.innerHTML = "<font color='red'>姓名不符合规范!</font>";
        name.value = "";
        return false;
    } else {
        Success(myDivName);
        return true;
    }
}

// 验证密码
function CheckPassword() {

    var mypassword = document.getElementById("txtPwd").value;
    var myDivpassword = document.getElementById("ErrorPassword");
    if (Trim(mypassword) == "") {
        myDivpassword.innerHTML = "<font color='red'>请输入密码!</font>";
        return false;
    }
    if (Trim(mypassword).length < 6) {
        myDivpassword.innerHTML = "<font color='red'>密码至少应为六位!</font>";
        mypassword = "";
        return false;
    } else {
        Success(myDivpassword);
        return true;
    }
}
//验证两次输入密码是否一致
function CheckSurePassword() {
    var mypassword = document.getElementById("txtPwd").value;
    var mysurepassword = document.getElementById("txtSurePwd").value;
    var myDivSurePassword = document.getElementById("ErrorSurePassword");
    if (Trim(mysurepassword) == "") {
        myDivSurePassword.innerHTML = "<font color='red'>请输入密码!</font>";
        return false;
    }
    if (mypassword != mysurepassword) {
        myDivSurePassword.innerHTML = "<font color='red'>两次输入的密码不一致!</font>";
        mysurepassword = "";
        return false;
    } else {
        Success(myDivSurePassword);
        return true;
    }
}
//验证邮箱
function CheckEamil() {
    var myEmail = document.getElementById("txtMail").value;
    var myDivEmail = document.getElementById("ErrorEmail");
    if (Trim(myEmail) == "") {
        myDivEmail.innerHTML = "<font color='red'>请输入邮箱!</font>";
        return false;
    }
    var re = new RegExp("^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$");
    var result = re.test(Trim(myEmail));
    if (!result) {
        myDivEmail.innerHTML = "<font color='red'>邮箱格式不正确!</font>";
        return false;
    }
    else {
        Success(myDivEmail);
        return true;
    }
}

//验证手机号
function CheckPhone() {
    var myPhone = document.getElementById("txtPhone").value;
    var myDivPhone = document.getElementById("ErrorPhone");
    if (Trim(myPhone) == "") {
        myDivPhone.innerHTML = "<font color='red'>请输入手机号!</font>";
        return false;
    }
    var re = new RegExp("^1[0-9]{10}$");
    var result = re.test(Trim(myPhone));
    if (!result) {
        myDivPhone.innerHTML = "<font color='red'>请输入正确的手机号!</font>";
        return false;
    }
    else {
        Success(myDivPhone);
        return true;
    }
}

//验证收货地址
function CheckAddress() {
    var myAddress = document.getElementById("txtAddress").value;
    var myDivAddress = document.getElementById("ErrorAddress");
    if (Trim(myAddress) == "") {
        myDivAddress.innerHTML = "<font color='red'>请输入收货地址!</font>";
        return false;
    } else {
        Success(myDivAddress);
        return true;
    }
}

//检查全部
function CheckAll() {
    if (CheckUserName() && CheckName() && CheckPassword() && CheckSurePassword() && CheckEamil() && CheckPhone() && CheckAddress()) {
        return true;
    }
    return false;

}