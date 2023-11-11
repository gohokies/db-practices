var Connection = require('tedious').Connection;  
var Request = require('tedious').Request;  
var TYPES = require('tedious').TYPES;  

var config = {  
    server: 'localhost',
    authentication: {
        type: 'default',
        options: {
            userName: 'sa',
            password: 'SQLPassword!0'
        }
    },
    options: {
        // If you are on Microsoft Azure, you need encryption:
        encrypt: true,
        trustServerCertificate: true,
        database: 'master'
    }
    };

var conn = new Connection(config);  
conn.on('connect', function(err) {  
    if(!err)
    {
        console.log("Connected");
        executeStatement();
    }
    else
    {
        console.log(err);
    }
});

conn.connect();

function executeStatement() {  
    var request = new Request("SELECT 'HelloWorld!' as message", function(err) {  
        if (err) {  
            console.log(err);
        }  
    });  

    var result = "";  
    request.on('row', function(columns) {  
        columns.forEach(function(column) {  
          if (column.value === null) {  
            console.log('NULL');  
          } else {  
            result+= column.value + " ";  
          }  
        });  

        console.log(result);
    });  

    request.on('done', function(rowCount, more) {  
        console.log(rowCount + ' rows returned');  
    });  
    
    // Close the connection after the final event emitted by the request, after the callback passes
    request.on("requestCompleted", function (rowCount, more) {
        conn.close();
    });

    conn.execSql(request);  
}  
