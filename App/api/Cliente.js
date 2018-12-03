const mysql = require(`mysql`);
const escdb = require ('../config/web.config')

const getSessaoCliente = (req, res, next) => {
    res.json( "Cliente está na sessão informada" )
}

module.exports = { getSessaoCliente }
