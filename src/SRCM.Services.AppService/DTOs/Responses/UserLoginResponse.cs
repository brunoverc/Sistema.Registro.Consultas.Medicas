using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SRCM.Services.AppService.DTOs.Responses
{
    // Define uma classe pública chamada 'UserLoginResponse'
    public class UserLoginResponse
    {
        // Construtor padrão (sem parâmetros), inicializa a lista 'Errors' como uma lista vazia
        public UserLoginResponse()
        {
            Errors = new List<string>(); // Inicializa a propriedade 'Errors' como uma lista vazia de strings
        }

        // Construtor que recebe um parâmetro 'success' (booleano) com valor padrão 'true'
        // Este construtor chama o construtor padrão usando ': this()' e inicializa a propriedade 'Success'
        public UserLoginResponse(bool success = true) : this()
        {
            Success = success; // Atribui o valor do parâmetro 'success' à propriedade 'Success'
        }

        // Construtor que recebe três parâmetros: 'success' (booleano), 'token' (string) e 'expirationDate' (DateTime)
        // Ele chama o construtor anterior com 'success' como parâmetro
        public UserLoginResponse(bool success, string token, DateTime expirationDate) : this(success)
        {
            Token = token; // Atribui o valor do parâmetro 'token' à propriedade 'Token'
            ExpirationDate = expirationDate; // Atribui o valor do parâmetro 'expirationDate' à propriedade 'ExpirationDate'
        }

        // Propriedade pública 'Success' que é apenas leitura (somente o set privado)
        public bool Success { get; private set; }

        // Atributo para ignorar a propriedade 'Token' durante a serialização se for nula
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        // Propriedade pública 'Token' que é apenas leitura (somente o set privado)
        public string Token { get; private set; }

        // Atributo para ignorar a propriedade 'ExpirationDate' durante a serialização se for nula
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        // Propriedade pública 'ExpirationDate' que é apenas leitura e aceita valores nulos (DateTime?)
        public DateTime? ExpirationDate { get; private set; }

        // Propriedade pública 'Errors', que é uma lista de strings e é apenas leitura (somente o set privado)
        public List<string> Errors { get; private set; }

        // Método público 'AddError' que adiciona uma string à lista de erros
        public void AddError(string error)
        {
            Errors.Add(error); // Adiciona o erro (string) à lista de erros
        }

        // Sobrecarga do método 'AddError' que adiciona uma lista de strings à lista de erros existente
        public void AddError(List<string> errors)
        {
            Errors.AddRange(errors); // Adiciona todos os erros da lista fornecida à lista de erros existente
        }
    }
}
