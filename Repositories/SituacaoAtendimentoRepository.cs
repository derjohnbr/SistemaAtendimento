﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class SituacaoAtendimentoRepository
    {
        public List<SituacaoAtendimentos> Listar()
        {
            var situacaoAtendimentos = new List<SituacaoAtendimentos>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM situacao_atendimentos";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            situacaoAtendimentos.Add(new SituacaoAtendimentos() {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Cor = linhas["cor"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
            }

            return situacaoAtendimentos;
        }
    }
}
