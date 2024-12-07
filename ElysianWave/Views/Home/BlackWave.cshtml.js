// 函數bitNumber()

// 得到輸入框中的值
var currentNoteIndex = 0;
function bitNumber() {
    let x = document.getElementById("heart").value.length;
    let y = document.getElementById("heart").value;
    let z = document.getElementById("nickname").value;
    // 小便利貼的"圖"做成陣列，配合遞增的currentNoteIndex做使用
    let notes = [
        document.getElementById('myImage_01'),
        document.getElementById('myImage_02'),
        document.getElementById('myImage_03'),
        document.getElementById('myImage_04'),
        document.getElementById('myImage_05'),
        document.getElementById('myImage_06'),

    ]
    // 暱稱的內容
    let notesnickname = [
        document.getElementById('re_Nickname_01'),
        document.getElementById('re_Nickname_02'),
        document.getElementById('re_Nickname_03'),
        document.getElementById('re_Nickname_04'),
        document.getElementById('re_Nickname_05'),
        document.getElementById('re_Nickname_06'),

    ]
    // 大便利貼的"內容"做成陣列，配合遞增的currentNoteIndex做使用
    let bigNotes = [
        document.getElementById('showtext_01'),
        document.getElementById('showtext_02'),
        document.getElementById('showtext_03'),
        document.getElementById('showtext_04'),
        document.getElementById('showtext_05'),
        document.getElementById('showtext_06'),

    ]
    if (y == '') {
        alert("未輸入訊息，請重新輸入");
    } else if (x < 100) {
        alert("輸入成功");

        if (currentNoteIndex < notes.length) {
            // 點一下只出現一個小便利貼,且小便利貼的屬名要屬在左下角
            notes[currentNoteIndex].style.visibility = "visible";
            notesnickname[currentNoteIndex].innerText = z;
            // 對應內容到大便利貼
            bigNotes[currentNoteIndex].innerText = y;
            currentNoteIndex++;
            // 當已經數量多到超過便利貼數量時，讓他重新從第一個便利貼開始填
            // 預想設計是把它與資料庫做連結，隨機選取資料庫的內容覆蓋上去
            document.getElementById('heart').value = ""
        } else if (currentNoteIndex >= notes.length) {
            // reset
            currentNoteIndex = 0;

            if (currentNoteIndex < notes.length) {
                // 點一下只出現一個便利貼
                notes[currentNoteIndex].style.visibility = "visible";
                // 對應內容到大便利貼
                bigNotes[currentNoteIndex].innerText = y;
                // 小便利貼的數屬名在左下角
                notesnickname[currentNoteIndex].innerText = z;

                currentNoteIndex++;
            }
            document.getElementById('heart').value = ""
        }

    } else {
        alert("輸入字數超過100字，請重新輸入");
    }
}

// 出現大便利貼01
function appearnotes_func01() {
    myImage_01.style.visibility = "hidden";
    re_Nickname_01.style.visibility = "hidden";
    appearnotes_01.style.visibility = "visible";
    showtext_01.style.visibility = "visible";
    closeButton_bigStickyNotes_01.style.visibility = "visible";
}
// 關閉大便利貼01

function closeButton_01() {
    myImage_01.style.visibility = "visible";
    re_Nickname_01.style.visibility = "visible";
    appearnotes_01.style.visibility = "hidden";
    showtext_01.style.visibility = "hidden";
    closeButton_bigStickyNotes_01.style.visibility = "hidden";
}
// 出現大便利貼02

function appearnotes_func02() {
    myImage_02.style.visibility = "hidden";
    re_Nickname_02.style.visibility = "hidden";
    appearnotes_02.style.visibility = "visible";
    showtext_02.style.visibility = "visible";
    closeButton_bigStickyNotes_02.style.visibility = "visible";
}


// 關閉大便利貼02

function closeButton_02() {
    myImage_02.style.visibility = "visible";
    re_Nickname_02.style.visibility = "visible";
    appearnotes_02.style.visibility = "hidden";
    showtext_02.style.visibility = "hidden";
    closeButton_bigStickyNotes_02.style.visibility = "hidden";
}


// 出現大便利貼03

function appearnotes_func03() {
    myImage_03.style.visibility = "hidden";
    re_Nickname_03.style.visibility = "hidden";
    appearnotes_03.style.visibility = "visible";
    showtext_03.style.visibility = "visible";
    closeButton_bigStickyNotes_03.style.visibility = "visible";
}


// 關閉大便利貼03

function closeButton_03() {
    myImage_03.style.visibility = "visible";
    re_Nickname_03.style.visibility = "visible";
    appearnotes_03.style.visibility = "hidden";
    showtext_03.style.visibility = "hidden";
    closeButton_bigStickyNotes_03.style.visibility = "hidden";
}


// 出現大便利貼04

function appearnotes_func04() {
    myImage_04.style.visibility = "hidden";
    re_Nickname_04.style.visibility = "hidden";
    appearnotes_04.style.visibility = "visible";
    showtext_04.style.visibility = "visible";
    closeButton_bigStickyNotes_04.style.visibility = "visible";
}

// 關閉大便利貼04

function closeButton_04() {
    myImage_04.style.visibility = "visible";
    re_Nickname_05.style.visibility = "visible";
    appearnotes_04.style.visibility = "hidden";
    showtext_04.style.visibility = "hidden";
    closeButton_bigStickyNotes_04.style.visibility = "hidden";
}

// 出現大便利貼05

function appearnotes_func05() {
    myImage_05.style.visibility = "hidden";
    re_Nickname_05.style.visibility = "hidden";
    appearnotes_05.style.visibility = "visible";
    showtext_05.style.visibility = "visible";
    closeButton_bigStickyNotes_05.style.visibility = "visible";
}

// 關閉大便利貼05

function closeButton_05() {
    myImage_05.style.visibility = "visible";
    re_Nickname_05.style.visibility = "visible";
    appearnotes_05.style.visibility = "hidden";
    showtext_05.style.visibility = "hidden";
    closeButton_bigStickyNotes_05.style.visibility = "hidden";
}

// 出現大便利貼06

function appearnotes_func06() {
    myImage_06.style.visibility = "hidden";
    re_Nickname_06.style.visibility = "hidden";
    appearnotes_06.style.visibility = "visible";
    showtext_06.style.visibility = "visible";
    closeButton_bigStickyNotes_06.style.visibility = "visible";
}

// 關閉大便利貼06

function closeButton_06() {
    myImage_06.style.visibility = "visible";
    re_Nickname_06.style.visibility = "visible";
    appearnotes_06.style.visibility = "hidden";
    showtext_06.style.visibility = "hidden";
    closeButton_bigStickyNotes_06.style.visibility = "hidden";
}