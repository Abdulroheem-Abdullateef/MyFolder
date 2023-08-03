function addRow() {
    var myName = document.getElementById("name");
    var quantity = document.getElementById("quantity");
    var unityprice = document.getElementById("unitprice");


    var table = document.getElementById("myTableData");

    var rowCount = table.rows.length;
    var row  = table.insertRow(rowCount);

    row.insertCell(0).innerHTML = '<input type = "button" value = "Delete" onClick = "Javascript:deleteRow(this)">';
    row.insertCell(1).innerHTML = myName.value;
    row.insertCell(2).insertHTML = quantity.value;
    row.insertCell(3).insertHTML = unityprice.value;

}

function delectRow(obj) {
    var index = obj.parentNode.parentNode.rowIndex;
    var table = document.getElementById("myTableData");
    table.delectRow(index);    
}

function addTable() {
    var myTableDiv = document.getElementById("myDynamicTable");
    
    var table = document.createElement('TABLE');
    table.border='1';
    var tableBody = document.createElement('TBODY');
    table.appendChild(tableBody);

    for(var i =0; i < 4; i++)
    {
        var tr = document.createElement('TR');
        tableBody.appendChild(tr);
        for(var j =0; j < 6; j++)
        {
                var td = document.createElement('TD');
                td.width = '75';
                td.appendChild(document.createTextNode("Cell" + i + "," + j));
                tr.appendChild(td);
        }
    }
    myTableDiv.appendChild(table);
}


function load() {
    console.log("page load finished");
    
}