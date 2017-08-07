/*--------------------显示当前时间---------------------*/
var timerID = null;
var timerRunning = false;

function stopclock() {
    if (timerRunning) {
        clearTimeout(timerID);
        timerRunning = false;
    }
}
function startclock() {
    stopclock();
    showtime();
}

function showtime() {
    var now = new Date();
    var year = now.getFullYear() + "年";
    var month = (now.getMonth() + 1) + "月";
    var day = now.getDate() + "日 ";
    var ymd = year + month + day;
    var hours = now.getHours();
    var minutes = now.getMinutes();
    var seconds = now.getSeconds()
    var timeValue = "" + ((hours >= 12) ? "下午 " : "上午 ")
    timeValue += ((hours > 12) ? hours - 12 : hours)
    timeValue += ((minutes < 10) ? ":0" : ":") + minutes
    timeValue += ((seconds < 10) ? ":0" : ":") + seconds
    //document.clock.thetime.value = timeValue;
    ymd = ymd + timeValue;
    document.getElementById("lblTime").innerHTML = ymd;
    timerID = setTimeout("showtime()", 1000);
    timerRunning = true;
}

/*--------------------设为主页和加入收藏---------------------*/
// 设置为主页 
function SetHome(obj, vrl) {
    try {
        obj.style.behavior = 'url(#default#homepage)'; obj.setHomePage(vrl);
    }
    catch (e) {
        if (window.netscape) {
            try {
                netscape.security.PrivilegeManager.enablePrivilege("UniversalXPConnect");
            }
            catch (e) {
                alert("此操作被浏览器拒绝！\n请在浏览器地址栏输入“about:config”并回车\n然后将 [signed.applets.codebase_principal_support]的值设置为'true',双击即可。");
            }
            var prefs = Components.classes['@mozilla.org/preferences-service;1'].getService(Components.interfaces.nsIPrefBranch);
            prefs.setCharPref('browser.startup.homepage', vrl);
        } else {
            alert("您的浏览器不支持，请按照下面步骤操作：1.打开浏览器设置。2.点击设置网页。3.输入：" + vrl + "点击确定。");
        }
    }
}
// 加入收藏 兼容360和IE6 
function shoucang(sTitle, sURL) {
    try {
        window.external.addFavorite(sURL, sTitle);
    }
    catch (e) {
        try {
            window.sidebar.addPanel(sTitle, sURL, "");
        }
        catch (e) {
            alert("加入收藏失败，请使用Ctrl+D进行添加");
        }
    }
}

//全文检索

function checkInputBlur(obj)
{
    var default_words = obj.attr("data-default");
    if (obj.val() == "")
    {
        obj.val(default_words);
        obj.css({
            "color": "#a9a9a9"
        });
    }
}
function checkInputFocus(obj)
{
    var default_words = obj.attr("data-default");
    if (obj.val() == default_words) {
        obj.val("").css({
            "color": "#333333"
        });
    }
}
