// GuruDev


/* 

Só agregação : public Marca marca;

// fazer o diagrama de classe (tarefa);

set =  controlar entrada
get =  saida


public class veiculo{

public modelo modeloveiculo;

}

nona questão:
classes staticas foram construidas para não ser instanciadas
dentro de uma classe static so coisas static, todos os atributos sao static.


agora, dentro de uma classe não static eu posso criar um um atributo static.
a diferença de um atributo static e não static.

atributos static pertence a classe e não a objetos.
um atributo static pertence a todos os veiculos 

se eu criar um atributo static na classe e criar depois um objeto desse atributo isso esta errado.

 */

// Validar CPF


string cpf = "024.091.372-88";

cpf = cpf.Replace(".", "").Replace("-","");


int a1 = Convert.ToInt32(cpf[0].ToString());

int a2 = Convert.ToInt32(cpf[1].ToString());

int a3 = Convert.ToInt32(cpf[2].ToString());

int a4 = Convert.ToInt32(cpf[3].ToString());

int a5 = Convert.ToInt32(cpf[4].ToString());

int a6 = Convert.ToInt32(cpf[5].ToString());

int a7 = Convert.ToInt32(cpf[6].ToString());

int a8 = Convert.ToInt32(cpf[7].ToString());

int a9 = Convert.ToInt32(cpf[8].ToString());

int a10 = Convert.ToInt32(cpf[9].ToString());

int a11 = Convert.ToInt32(cpf[10].ToString());
