const mysqlx = require('@mysql/xdevapi');

const config = {
    password: 'SQLPassword',
    user: 'tiger',
    host: 'localhost',
    port: '33060',
    schema: 'myapp'
};

mysqlx.getSession(config)
    .then(session => {
        console.log(session.inspect());
        session.close();
    });
