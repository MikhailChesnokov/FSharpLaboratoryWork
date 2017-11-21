module Basics

// Неймспецсы
open System.Numerics

// Объявления констант различных типов
let a_byte    : byte = 2uy
let a_sbyte   : sbyte = 2y
let a_double  : float = 2.0
let a_float32 : float32 = 2.0f
let a_int     : int = 2
let a_uint    : uint32 = 2u
//let a_bigint  : BigInteger = 2I
let a_decimal : decimal = 2m

//Функции
    // Определение
let func_name p1 p2 pn = p1 + p2 + pn
    // Вызов
// func_name 1 2 3

// Кортежи
let cortage = (1, '2' ,"three")

// Каррирование
let inc = (+) 1
let r = inc 2   // r == 3

// Опциональный тип
let possible_null_func par = 
    if par % 2 = 0 then Some(par) else None

// Пользовательский тип
type simple_ans = (int*int) option
type ans =
    None // Нет корней
    | One of float // Один корень
    | Two of (float*float) // Два корня

// Сопоставление с образцом
let get_sum_roots ans =
   match ans with
   None -> 0.0
   | One(x1:float) when x1 = 0.0 -> 0.0 // Просто для демонстрации when
   | One(x1:float) -> x1
   | Two(x1:float, x2:float) -> x1 + x2

// ----Списки-----
// Определение (не нашел почему не работает)
//type int_list =
//    []
//    | (::) int int*int_list

let get_list_head L = 
    match L with
    [] -> None
    | (h::t) -> h

let rec get_list_length L =
    match L with 
    [] -> 0
    | (h::t) -> 1 + get_list_length t
// Оператор добавления элемента ::
let four_list = 1 :: [2;3;4]
// Оператор объединения @
let five_list = [1;2;3] @ [4;5]
// Способы задания
let first_way = [1;2;3]
let sec_way = [1..3]
let third_way = 
    let x = 1
    [yield x; yield x+1; yield x+2]
// Хвостовая рекурсия
let rec factorial n acc =
    if n = 1 then acc
             else factorial (n-1) (acc * n) // рекурсивный вызов последним действием

