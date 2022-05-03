create table item
(
    name        varchar(100)  not null,
    description varchar(500)  not null,
    id          int identity
        constraint item_pk
        primary key,
    price       decimal       not null,
    placeDate   datetime      not null,
    status      int default 0 not null,
    category    int default 0 not null,
    quantity    int default 1 not null
)
    go

create unique index item_id_uindex
    on item (id)
    go

create table [user]
(
    user_id    int identity
    constraint user_pk
    primary key,
    first_name varchar(80),
    last_name  varchar(80),
    email      varchar(100)  not null,
    password   varchar(258)  not null,
    phone      varchar(100),
    role       int default 0 not null
    )
    go

create table favourite
(
    user_id int not null
        constraint favourite_user_user_id_fk
            references [user]
        on delete cascade,
    item_id int not null
        constraint favourite_item_id_fk
            references item
            on delete cascade
)
    go

create table [order]
(
    order_id int identity
    constraint order_pk
    primary key,
    date     datetime not null,
    user_id  int
    constraint order_user__fk
    references [user]
    on delete cascade,
    item_id  int
    constraint order_item__fk
    references item
    on delete cascade
)
    go

create unique index order_order_id_uindex
    on [order] (order_id)
    go

create table review
(
    review_id   int identity
        constraint review_pk
        primary key,
    stars       int not null,
    writer_id   int not null
        constraint review_writer_id_fk
            references [user],
    receiver_id int not null
        constraint review_receiver_id_fk
            references [user]
        on delete cascade
)
    go

create unique index review_review_id_uindex
    on review (review_id)
    go

create unique index user_email_uindex
    on [user] (email)
    go

