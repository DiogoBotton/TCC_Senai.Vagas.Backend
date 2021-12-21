using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.Vagas.Backend.Migrations
{
    public partial class ContextCotagroDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaixasSalariais",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixasSalariais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaResponsaveis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaResponsaveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequerimentosMatriculas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequerimentosMatriculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusEstagios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusEstagios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusUsuarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusVagas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusVagas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TermosOuEgressosAlunos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermosOuEgressosAlunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCnaes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCnaes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposAtividadesCnaes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposAtividadesCnaes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCursos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposEmpresas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEmpresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposExperiencias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposExperiencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UfSiglas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UFEstado = table.Column<string>(nullable: false),
                    UFSigla = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UfSiglas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RMA = table.Column<string>(nullable: true),
                    Sexo = table.Column<bool>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataMatricula = table.Column<DateTime>(nullable: false),
                    TermoOuEgressoAlunoId = table.Column<long>(nullable: false),
                    TipoCursoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_TermosOuEgressosAlunos_TermoOuEgressoAlunoId",
                        column: x => x.TermoOuEgressoAlunoId,
                        principalTable: "TermosOuEgressosAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_TiposCursos_TipoCursoId",
                        column: x => x.TipoCursoId,
                        principalTable: "TiposCursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    TipoUsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TiposUsuarios_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TiposUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    UfSiglaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipios_UfSiglas_UfSiglaId",
                        column: x => x.UfSiglaId,
                        principalTable: "UfSiglas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ValidacaoUsuarioCandidatos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(nullable: false),
                    DataValida = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    AlunoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidacaoUsuarioCandidatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidacaoUsuarioCandidatos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlterarCredenciais",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(nullable: true),
                    DataValida = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    NovoEmail = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlterarCredenciais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlterarCredenciais_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoStatusUsuarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Atual = table.Column<bool>(nullable: false),
                    StatusUsuarioId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoStatusUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoStatusUsuarios_StatusUsuarios_StatusUsuarioId",
                        column: x => x.StatusUsuarioId,
                        principalTable: "StatusUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricoStatusUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioAdministradores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NIF = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAdministradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioAdministradores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioCandidatoAlunos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCandidatoAlunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioCandidatoAlunos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioCandidatoAlunos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    MunicipioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreasInteressesCandidatosAlunos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    AreaId = table.Column<long>(nullable: false),
                    UsuarioCandidatoAlunoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasInteressesCandidatosAlunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreasInteressesCandidatosAlunos_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreasInteressesCandidatosAlunos_UsuarioCandidatoAlunos_UsuarioCandidatoAlunoId",
                        column: x => x.UsuarioCandidatoAlunoId,
                        principalTable: "UsuarioCandidatoAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilUsuarioCandidatoAlunos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LinkExterno = table.Column<string>(nullable: true),
                    SobreOCandidato = table.Column<string>(nullable: true),
                    UsuarioCandidatoAlunoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilUsuarioCandidatoAlunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilUsuarioCandidatoAlunos_UsuarioCandidatoAlunos_UsuarioCandidatoAlunoId",
                        column: x => x.UsuarioCandidatoAlunoId,
                        principalTable: "UsuarioCandidatoAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    EnderecoId = table.Column<long>(nullable: false),
                    TipoEmpresaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_TiposEmpresas_TipoEmpresaId",
                        column: x => x.TipoEmpresaId,
                        principalTable: "TiposEmpresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AtividadeCnaes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoCnaeId = table.Column<long>(nullable: false),
                    TipoAtividadeCnaeId = table.Column<long>(nullable: false),
                    EmpresaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeCnaes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadeCnaes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtividadeCnaes_TiposAtividadesCnaes_TipoAtividadeCnaeId",
                        column: x => x.TipoAtividadeCnaeId,
                        principalTable: "TiposAtividadesCnaes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtividadeCnaes_TipoCnaes_TipoCnaeId",
                        column: x => x.TipoCnaeId,
                        principalTable: "TipoCnaes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QSAs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Qualificacao = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QSAs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QSAs_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEmpresas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEmpresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estagios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataTerminoPrevisto = table.Column<DateTime>(nullable: false),
                    DataTerminoEfetivo = table.Column<DateTime>(nullable: false),
                    DiasContrato = table.Column<int>(nullable: false),
                    Contrato = table.Column<bool>(nullable: false),
                    PlanoEstagio = table.Column<bool>(nullable: false),
                    Desligamento = table.Column<bool>(nullable: false),
                    RequerimentoMatriculaId = table.Column<long>(nullable: false),
                    TermoOuEgressoAlunoId = table.Column<long>(nullable: false),
                    PessoaResponsavelId = table.Column<long>(nullable: false),
                    EnderecoId = table.Column<long>(nullable: false),
                    AlunoId = table.Column<long>(nullable: false),
                    UsuarioEmpresaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estagios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estagios_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estagios_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estagios_PessoaResponsaveis_PessoaResponsavelId",
                        column: x => x.PessoaResponsavelId,
                        principalTable: "PessoaResponsaveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estagios_RequerimentosMatriculas_RequerimentoMatriculaId",
                        column: x => x.RequerimentoMatriculaId,
                        principalTable: "RequerimentosMatriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estagios_TermosOuEgressosAlunos_TermoOuEgressoAlunoId",
                        column: x => x.TermoOuEgressoAlunoId,
                        principalTable: "TermosOuEgressosAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estagios_UsuarioEmpresas_UsuarioEmpresaId",
                        column: x => x.UsuarioEmpresaId,
                        principalTable: "UsuarioEmpresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeVaga = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    DescricaoVaga = table.Column<string>(nullable: true),
                    DataEncerramento = table.Column<DateTime>(nullable: false),
                    StatusVagaId = table.Column<long>(nullable: false),
                    TipoExperienciaId = table.Column<long>(nullable: false),
                    UsuarioEmpresaId = table.Column<long>(nullable: false),
                    MunicipioId = table.Column<long>(nullable: false),
                    FaixaSalarialId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vagas_FaixasSalariais_FaixaSalarialId",
                        column: x => x.FaixaSalarialId,
                        principalTable: "FaixasSalariais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vagas_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vagas_StatusVagas_StatusVagaId",
                        column: x => x.StatusVagaId,
                        principalTable: "StatusVagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vagas_TiposExperiencias_TipoExperienciaId",
                        column: x => x.TipoExperienciaId,
                        principalTable: "TiposExperiencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vagas_UsuarioEmpresas_UsuarioEmpresaId",
                        column: x => x.UsuarioEmpresaId,
                        principalTable: "UsuarioEmpresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContatoEstagios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TelefoneOuEmail = table.Column<string>(nullable: false),
                    EstagioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoEstagios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContatoEstagios_Estagios_EstagioId",
                        column: x => x.EstagioId,
                        principalTable: "Estagios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoStatusEstagios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Explicacao = table.Column<string>(nullable: false),
                    Atual = table.Column<bool>(nullable: false),
                    StatusEstagioId = table.Column<long>(nullable: false),
                    EstagioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoStatusEstagios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoStatusEstagios_Estagios_EstagioId",
                        column: x => x.EstagioId,
                        principalTable: "Estagios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricoStatusEstagios_StatusEstagios_StatusEstagioId",
                        column: x => x.StatusEstagioId,
                        principalTable: "StatusEstagios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreasVagasRecomendadas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    AreaId = table.Column<long>(nullable: false),
                    VagaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasVagasRecomendadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreasVagasRecomendadas_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreasVagasRecomendadas_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConvitesEntrevistas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataHoraEntrevista = table.Column<DateTime>(nullable: false),
                    InfosComplementares = table.Column<string>(nullable: true),
                    EnderecoId = table.Column<long>(nullable: false),
                    UsuarioCandidatoAlunoId = table.Column<long>(nullable: false),
                    VagaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvitesEntrevistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConvitesEntrevistas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConvitesEntrevistas_UsuarioCandidatoAlunos_UsuarioCandidatoAlunoId",
                        column: x => x.UsuarioCandidatoAlunoId,
                        principalTable: "UsuarioCandidatoAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConvitesEntrevistas_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inscricoes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    RecebeuConvite = table.Column<bool>(nullable: false),
                    UsuarioCandidatoAlunoId = table.Column<long>(nullable: false),
                    VagaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscricoes_UsuarioCandidatoAlunos_UsuarioCandidatoAlunoId",
                        column: x => x.UsuarioCandidatoAlunoId,
                        principalTable: "UsuarioCandidatoAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscricoes_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlterarCredenciais_UsuarioId",
                table: "AlterarCredenciais",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TermoOuEgressoAlunoId",
                table: "Alunos",
                column: "TermoOuEgressoAlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoCursoId",
                table: "Alunos",
                column: "TipoCursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasInteressesCandidatosAlunos_AreaId",
                table: "AreasInteressesCandidatosAlunos",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasInteressesCandidatosAlunos_UsuarioCandidatoAlunoId",
                table: "AreasInteressesCandidatosAlunos",
                column: "UsuarioCandidatoAlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasVagasRecomendadas_AreaId",
                table: "AreasVagasRecomendadas",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasVagasRecomendadas_VagaId",
                table: "AreasVagasRecomendadas",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadeCnaes_EmpresaId",
                table: "AtividadeCnaes",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadeCnaes_TipoAtividadeCnaeId",
                table: "AtividadeCnaes",
                column: "TipoAtividadeCnaeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadeCnaes_TipoCnaeId",
                table: "AtividadeCnaes",
                column: "TipoCnaeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContatoEstagios_EstagioId",
                table: "ContatoEstagios",
                column: "EstagioId");

            migrationBuilder.CreateIndex(
                name: "IX_ConvitesEntrevistas_EnderecoId",
                table: "ConvitesEntrevistas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConvitesEntrevistas_UsuarioCandidatoAlunoId",
                table: "ConvitesEntrevistas",
                column: "UsuarioCandidatoAlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConvitesEntrevistas_VagaId",
                table: "ConvitesEntrevistas",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_EnderecoId",
                table: "Empresas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoEmpresaId",
                table: "Empresas",
                column: "TipoEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_MunicipioId",
                table: "Enderecos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagios_AlunoId",
                table: "Estagios",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagios_EnderecoId",
                table: "Estagios",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagios_PessoaResponsavelId",
                table: "Estagios",
                column: "PessoaResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagios_RequerimentoMatriculaId",
                table: "Estagios",
                column: "RequerimentoMatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagios_TermoOuEgressoAlunoId",
                table: "Estagios",
                column: "TermoOuEgressoAlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagios_UsuarioEmpresaId",
                table: "Estagios",
                column: "UsuarioEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoStatusEstagios_EstagioId",
                table: "HistoricoStatusEstagios",
                column: "EstagioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoStatusEstagios_StatusEstagioId",
                table: "HistoricoStatusEstagios",
                column: "StatusEstagioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoStatusUsuarios_StatusUsuarioId",
                table: "HistoricoStatusUsuarios",
                column: "StatusUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoStatusUsuarios_UsuarioId",
                table: "HistoricoStatusUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_UsuarioCandidatoAlunoId",
                table: "Inscricoes",
                column: "UsuarioCandidatoAlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_VagaId",
                table: "Inscricoes",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_UfSiglaId",
                table: "Municipios",
                column: "UfSiglaId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuarioCandidatoAlunos_UsuarioCandidatoAlunoId",
                table: "PerfilUsuarioCandidatoAlunos",
                column: "UsuarioCandidatoAlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_QSAs_EmpresaId",
                table: "QSAs",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioAdministradores_UsuarioId",
                table: "UsuarioAdministradores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCandidatoAlunos_AlunoId",
                table: "UsuarioCandidatoAlunos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCandidatoAlunos_UsuarioId",
                table: "UsuarioCandidatoAlunos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEmpresas_EmpresaId",
                table: "UsuarioEmpresas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEmpresas_UsuarioId",
                table: "UsuarioEmpresas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_FaixaSalarialId",
                table: "Vagas",
                column: "FaixaSalarialId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_MunicipioId",
                table: "Vagas",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_StatusVagaId",
                table: "Vagas",
                column: "StatusVagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_TipoExperienciaId",
                table: "Vagas",
                column: "TipoExperienciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_UsuarioEmpresaId",
                table: "Vagas",
                column: "UsuarioEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidacaoUsuarioCandidatos_AlunoId",
                table: "ValidacaoUsuarioCandidatos",
                column: "AlunoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlterarCredenciais");

            migrationBuilder.DropTable(
                name: "AreasInteressesCandidatosAlunos");

            migrationBuilder.DropTable(
                name: "AreasVagasRecomendadas");

            migrationBuilder.DropTable(
                name: "AtividadeCnaes");

            migrationBuilder.DropTable(
                name: "ContatoEstagios");

            migrationBuilder.DropTable(
                name: "ConvitesEntrevistas");

            migrationBuilder.DropTable(
                name: "HistoricoStatusEstagios");

            migrationBuilder.DropTable(
                name: "HistoricoStatusUsuarios");

            migrationBuilder.DropTable(
                name: "Inscricoes");

            migrationBuilder.DropTable(
                name: "PerfilUsuarioCandidatoAlunos");

            migrationBuilder.DropTable(
                name: "QSAs");

            migrationBuilder.DropTable(
                name: "UsuarioAdministradores");

            migrationBuilder.DropTable(
                name: "ValidacaoUsuarioCandidatos");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "TiposAtividadesCnaes");

            migrationBuilder.DropTable(
                name: "TipoCnaes");

            migrationBuilder.DropTable(
                name: "Estagios");

            migrationBuilder.DropTable(
                name: "StatusEstagios");

            migrationBuilder.DropTable(
                name: "StatusUsuarios");

            migrationBuilder.DropTable(
                name: "Vagas");

            migrationBuilder.DropTable(
                name: "UsuarioCandidatoAlunos");

            migrationBuilder.DropTable(
                name: "PessoaResponsaveis");

            migrationBuilder.DropTable(
                name: "RequerimentosMatriculas");

            migrationBuilder.DropTable(
                name: "FaixasSalariais");

            migrationBuilder.DropTable(
                name: "StatusVagas");

            migrationBuilder.DropTable(
                name: "TiposExperiencias");

            migrationBuilder.DropTable(
                name: "UsuarioEmpresas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TermosOuEgressosAlunos");

            migrationBuilder.DropTable(
                name: "TiposCursos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "TiposEmpresas");

            migrationBuilder.DropTable(
                name: "TiposUsuarios");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "UfSiglas");
        }
    }
}
