const { Client } = require('pg');

(async () => {
  const client = new Client({
    host: "localhost",
    port: "5432",
    user: "postgres",
    password: "SQLPassword",
    database: "postgres"
  });
  await client.connect();
  
  const res = await client.query("SELECT 'HelloWorld!' as message");
  console.log(res.rows[0].message);
  
  await client.end();
})();