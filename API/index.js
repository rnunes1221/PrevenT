const express = require("express");
const cors = require("cors");
const mariadb = require("mariadb");
const http = require("http");
const axios = require("axios");
const app = express();

const pool = mariadb.createPool({
    host: "192.168.102.78",
    port: "3306",
    user: "root",
    password: "rmhuuadm",
    database: "ocsweb",
    connectionLimit: 1
})

app.use(express.json(), cors());

app.get("/computadores", async(req, res) => {
    pool.getConnection().then(conn => {
      conn.query(`SELECT ID, NAME, IPADDR, PROCESSORT, USERID, OSNAME, WORKGROUP, a.TAG FROM hardware h
                  JOIN accountinfo a  ON  h.ID = a.HARDWARE_ID 
                  ORDER BY h.NAME `)
        .then(rows => {
          Object.keys(rows).forEach(function(index){
            let osname = rows[index].OSNAME;
            let workgroup = rows[index].WORKGROUP;
            
            
            if (typeof(osname) !== "undefined") {
              rows[index].OSNAME = osname.replace("Microsoft ", "").replace("Professional", "Pro").replace("Insider Preview", "").replace("Edition", "").replace("Standard", "");
            }
            if (typeof(workgroup) === "string") {
              rows[index].WORKGROUP = workgroup.replace(".com.br", "");
            }
          });

          return res.send(rows);
        })
        .then(res => {
          conn.release();
        })
        .catch(err => {
          return res(err.data);
          conn.release();
        })
        
    }).catch(err => {
        return res.send(err);
    });
});



app.listen(80, () => {
    console.log("Servidor iniciado");
});