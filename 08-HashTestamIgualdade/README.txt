
Como as coleções Hash testam igualdade?
• Se GetHashCode e Equals estiverem implementados: 
• Primeiro GetHashCode. Se der igual, usa Equals para confirmar. 
• Se GetHashCode e Equals NÃO estiverem implementados: 
• Tipos referência: compara as referências dos objetos
• Tipos valor: comparar os valores dos atributos