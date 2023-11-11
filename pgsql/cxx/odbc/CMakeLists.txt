find_package(ODBC)

add_executable(pgsql_odbc_sample sample.cpp)

target_link_libraries(pgsql_odbc_sample ODBC::ODBC)